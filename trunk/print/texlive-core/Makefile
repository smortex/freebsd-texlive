# $FreeBSD$

PORTNAME=	texlive-core
PORTVERSION=	20140525
CATEGORIES=	print
MASTER_SITES=	ftp://tug.org/historic/systems/texlive/${PORTVERSION:C/^(....).*/\1/}/
DISTNAME=	texlive-${PORTVERSION}-source

MAINTAINER=	romain@FreeBSD.org
COMMENT=	TeXLive (binaries)

LIB_DEPENDS=	libfontconfig.so:${PORTSDIR}/x11-fonts/fontconfig

CONFLICTS=	teTeX-base-[0-9]*

CFLAGS+=	-fPIC
CONFIGURE_ARGS=	--bindir=${PREFIX}/bin \
		--libdir=${PREFIX}/lib \
		--datadir=${PREFIX}/share \
		--enable-build-in-source-tree \
		--disable-native-texlive-build \
		--with-banner-add="/FreeBSD"
GNU_CONFIGURE=	yes
MAKE_ARGS+=	GNUMAKE="${GMAKE}" ARCH="arch/unix"
USE_XORG=	x11 xaw xmu xp xproto
USES=		perl5 gmake iconv libtool pkgconfig shebangfix tar:xz
INSTALL_TARGET=	install-strip
SHEBANG_FILES=	${WRKSRC}/texk/texlive/linked_scripts/accfonts/mkt1font \
		${WRKSRC}/texk/texlive/linked_scripts/accfonts/vpl2ovp \
		${WRKSRC}/texk/texlive/linked_scripts/accfonts/vpl2vpl \
		${WRKSRC}/texk/texlive/linked_scripts/arara/arara.sh \
		${WRKSRC}/texk/texlive/linked_scripts/bibexport/bibexport.sh \
		${WRKSRC}/texk/texlive/linked_scripts/convbkmk/convbkmk.rb \
		${WRKSRC}/texk/texlive/linked_scripts/ctanupload/ctanupload.pl \
		${WRKSRC}/texk/texlive/linked_scripts/de-macro/de-macro \
		${WRKSRC}/texk/texlive/linked_scripts/dtxgen/dtxgen \
		${WRKSRC}/texk/texlive/linked_scripts/exceltex/exceltex \
		${WRKSRC}/texk/texlive/linked_scripts/findhyph/findhyph \
		${WRKSRC}/texk/texlive/linked_scripts/fragmaster/fragmaster.pl \
		${WRKSRC}/texk/texlive/linked_scripts/installfont/installfont-tl \
		${WRKSRC}/texk/texlive/linked_scripts/kotex-utils/jamo-normalize.pl \
		${WRKSRC}/texk/texlive/linked_scripts/latexindent/latexindent.pl \
		${WRKSRC}/texk/texlive/linked_scripts/latexpand/latexpand \
		${WRKSRC}/texk/texlive/linked_scripts/ltxfileinfo/ltxfileinfo \
		${WRKSRC}/texk/texlive/linked_scripts/ltximg/ltximg.pl \
		${WRKSRC}/texk/texlive/linked_scripts/lua2dox/lua2dox_filter \
		${WRKSRC}/texk/texlive/linked_scripts/mathspic/mathspic.pl \
		${WRKSRC}/texk/texlive/linked_scripts/mf2pt1/mf2pt1.pl \
		${WRKSRC}/texk/texlive/linked_scripts/multibibliography/multibibliography.pl \
		${WRKSRC}/texk/texlive/linked_scripts/rubik/rubikrotation.pl \
		${WRKSRC}/texk/texlive/linked_scripts/splitindex/splitindex.pl \
		${WRKSRC}/texk/texlive/linked_scripts/svn-multi/svn-multi.pl \
		${WRKSRC}/texk/texlive/linked_scripts/texdirflatten/texdirflatten \
		${WRKSRC}/texk/texlive/linked_scripts/ulqda/ulqda.pl \
		${WRKSRC}/texk/texlive/linked_scripts/urlbst/urlbst

INFO=		dvipng dvips kpathsea tlbuild web2c

post-extract:
	@${FIND} ${WRKSRC} -name 'Makefile.in' | ${XARGS} ${SED} -EI '' \
	    -e 's,(\$$[{(]prefix[)}])/(texmf|\$$[{(]scriptsdir[)}]),\1/share/\2,'
	@${REINPLACE_CMD} 's/\$$(REL)\/texmf\//\$$(REL)\/share\/texmf\//g' ${WRKSRC}/texk/texlive/linked_scripts/Makefile.in
	@${REINPLACE_CMD} 's/\$$(REL)\/texmf-dist\//\$$(REL)\/share\/texmf-dist\//g' ${WRKSRC}/texk/texlive/linked_scripts/Makefile.in

post-install:
.for l in amstex cslatex csplain eplain etex jadetex latex lollipop mex mllatex mltex pdfcslatex pdfcsplain pdfetex pdfjadetex pdflatex pdfmex pdfxmltex texsis utf8mex xmltex
	@${LN} -sf pdftex ${STAGEDIR}${PREFIX}/bin/${l}
.endfor
.for l in dvilualatex dviluatex lualatex lualollipop
	@${LN} -sf luatex ${STAGEDIR}${PREFIX}/bin/${l}
.endfor
.for l in xelatex xelollipop
	@${LN} -sf xetex ${STAGEDIR}${PREFIX}/bin/${l}
.endfor
	@${LN} -sf euptex ${STAGEDIR}${PREFIX}/bin/uplatex
	@${LN} -sf eptex ${STAGEDIR}${PREFIX}/bin/platex
	@${LN} -sf aleph ${STAGEDIR}${PREFIX}/bin/lamed

.include <bsd.port.mk>
