# New ports collection makefile for:	texlive
# Date created:		2008-11-22
# Whom:			Romain Tartiere <romain@blogreen.org>
#
# $FreeBSD$
#

PORTNAME=	texlive-core
PORTVERSION=	20080816
PORTREVISION=	2
CATEGORIES=	print
MASTER_SITES=	${MASTER_SITE_TEX_CTAN}
MASTER_SITE_SUBDIR=	systems/texlive/Source
DISTNAME=	texlive-${PORTVERSION}-source

MAINTAINER=	romain@blogreen.org
COMMENT=	TeXLive (binaries)

LIB_DEPENDS=	fontconfig.1:${PORTSDIR}/x11-fonts/fontconfig

CONFLICTS=	teTeX-base-[0-9]*

USE_XLIB=	yes
USE_PERL5=	yes

USE_LZMA=	yes
GNU_CONFIGURE=	yes
USE_GMAKE=	yes
CONFIGURE_ENV=	GNUMAKE=${GMAKE} \
		CFLAGS="-I${LOCALBASE}/include" \
		CXXFLAGS="-I${LOCALBASE}/include" \
		LDFLAGS="-L${LOCALBASE}/lib"
CONFIGURE_ARGS=	--bindir=${LOCALBASE}/bin \
		--libdir=${LOCALBASE}/lib \
		--datadir=${LOCALBASE}/share \
		--without-texinfo \
		--without-xindy \
		--with-system-zlib \
		--with-zlib-include=${LOCALBASE}/include \
		--with-zlib-libdir=${LOCALBASE}/lib

MAN1=		afm2pl.1 afm2tfm.1 allcm.1 allneeded.1 amstex.1 \
		bbox.1 bibtex.1 cfftot1.1 ctangle.1 ctie.1 ctxtools.1 \
		cweave.1 cweb.1 detex.1 dmp.1 dt2dv.1 dv2dt.1 dvi2fax.1 \
		dvi2tty.1 dvibook.1 dviconcat.1 dvicopy.1 dvidvi.1 dvigif.1 \
		dvihp.1 dvilj.1 dvipdfm.1 dvipdft.1 dvipng.1 dvipos.1 \
		dvips.1 dvired.1 dviselect.1 dvitodvi.1 dvitomp.1 dvitype.1 \
		e2pall.1 ebb.1 eplain.1 epsffit.1 epstopdf.1 etex.1 \
		extractres.1 fixdlsrps.1 fixfmps.1 fixmacps.1 fixpsditps.1 \
		fixpspps.1 fixscribeps.1 fixtpps.1 fixwfwps.1 fixwpps.1 \
		fixwwps.1 fmtutil-sys.1 fmtutil.1 fontinst.1 getafm.1 \
		getnonfreefonts-sys.1 getnonfreefonts.1 gftodvi.1 gftopk.1 \
		gftype.1 gsftopk.1 hbf2gf.1 includeres.1 \
		kpseaccess.1 kpsepath.1 kpsereadlink.1 \
		kpsestat.1 kpsetool.1 kpsewhere.1 kpsewhich.1 lacheck.1 \
		lambda.1 latex.1 mag.1 makeindex.1 makempx.1 \
		makempy.1 mf-nowin.1 mf.1 mft.1 mkindex.1 mkjobtexmf.1 \
		mkocp.1 mkofm.1 mktexlsr.1 mktexmf.1 mktexpk.1 mktextfm.1 \
		mmafm.1 mmpfb.1 mpost.1 mpto.1 mptopdf.1 newer.1 ofm2opl.1 \
		omega.1 opl2ofm.1 otfinfo.1 otftotfm.1 otp2ocp.1 outocp.1 \
		ovf2ovp.1 ovp2ovf.1 oxdvi.1 patgen.1 pdfetex.1 pdflatex.1 \
		pdftex.1 pdftools.1 pdftosrc.1 pfb2pfa.1 \
		pk2bm.1 pktogf.1 pktype.1 pltotf.1 pooltype.1 ps2eps.1 \
		ps2frag.1 ps2pk.1 psbook.1 pslatex.1 psmerge.1 psnup.1 \
		psresize.1 psselect.1 pstopdf.1 pstops.1 rubibtex.1 \
		rumakeindex.1 synctex.1 t1ascii.1 t1asm.1 t1binary.1 \
		t1disasm.1 t1dotlessj.1 t1lint.1 t1mac.1 t1reencode.1 \
		t1testpage.1 t1unmac.1 tangle.1 tcdialog.1 tex.1 \
		texconfig-sys.1 texconfig.1 texdoctk.1 texexec.1 texfind.1 \
		texfont.1 texlinks.1 \
		texmfstart.1 textools.1 texutil.1 tftopl.1 thumbpdf.1 tie.1 \
		ttf2afm.1 ttf2pk.1 ttf2tfm.1 ttftotype42.1 updmap-sys.1 \
		updmap.1 vftovp.1 vlna.1 vptovf.1 weave.1 xdvi.1
MLINKS=		allcm.1 allec.1 dvilj.1 dvilj2p.1 dvilj.1 dvilj4.1 dvilj.1 \
		dvilj4l.1 dvilj.1 dvilj6.1 kpsetool.1 kpsexpand.1 fmtutil.1 \
		mktexfmt.1 dvicopy.1 odvicopy.1 dvips.1 odvips.1 dvitype.1 \
		odvitype.1 mktexlsr.1 texhash.1
MAN5=		fmtutil.cnf.5 synctex.5 updmap.cfg.5
INFO=		dvipng dvips kpathsea web2c

post-extract:
	@${REINPLACE_CMD} -e 's/^ARCH =/xARCH =/' -e 's/$$(ARCH)/$$(xARCH)/g' \
		${WRKSRC}/libs/freetype/lib/arch/unix/Makefile.in \
		${WRKSRC}/libs/freetype/test/arch/unix/Makefile.in

post-configure:
	cd ${WRKSRC}/libs/zziplib && ./configure

post-install:
	@echo "Updating ls-R databases..."
	@mktexlsr

.include <bsd.port.pre.mk>
.include <bsd.port.post.mk>
