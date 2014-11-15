# $FreeBSD$

PORTNAME=	collection-langchinese
PORTVERSION=	20141114
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Chinese

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-dvipdfmx \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/share/texmf-dist/dvips/base/color.pro:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/etex/xbmc10.mf:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf-dist/dvips/gsftopk/render.ps:${PORTSDIR}/print/texlive-gsftopk \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/oberdiek/ifluatex.sty:${PORTSDIR}/print/texlive-ifluatex \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-lib/grayf.mf:${PORTSDIR}/print/texlive-knuth-lib \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-local/black.mf:${PORTSDIR}/print/texlive-knuth-local \
		${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/scripts/lua-alt-getopt/alt_getopt.lua:${PORTSDIR}/print/texlive-lua-alt-getopt \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/expr.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/mft/base/README:${PORTSDIR}/print/texlive-mfware \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/dummy-space/dummy-space.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-tetex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/texconfig.sh:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf-dist/dvips/xdvi/config.xdvi:${PORTSDIR}/print/texlive-xdvi \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/adobemapping/LICENSE:${PORTSDIR}/print/texlive-adobemapping \
		${LOCALBASE}/share/texmf-dist/fonts/enc/dvips/c90/c90.enc:${PORTSDIR}/print/texlive-c90 \
		${LOCALBASE}/share/texmf-dist/tex/latex/cjk/contrib/wadalab/c42goth.fd:${PORTSDIR}/print/texlive-cjk \
		${LOCALBASE}/share/texmf-dist/tex/latex/cjkpunct/CJKpunct.sty:${PORTSDIR}/print/texlive-cjkpunct \
		${LOCALBASE}/share/texmf-dist/hbf2gf/README:${PORTSDIR}/print/texlive-cjkutils \
		${LOCALBASE}/share/texmf-dist/fonts/sfd/dnp/DNP.sfd:${PORTSDIR}/print/texlive-dnp \
		${LOCALBASE}/share/texmf-dist/dvips/garuda-c90/config.garuda-c90:${PORTSDIR}/print/texlive-garuda-c90 \
		${LOCALBASE}/share/texmf-dist/dvips/norasi-c90/config.norasi-c90:${PORTSDIR}/print/texlive-norasi-c90 \
		${LOCALBASE}/share/texmf-dist/tex/latex/xcjk2uni/cmap/c0001.cmap:${PORTSDIR}/print/texlive-xcjk2uni \
		${LOCALBASE}/share/texmf-dist/tex/latex/zxjafont/zxjafont.sty:${PORTSDIR}/print/texlive-zxjafont \
		${LOCALBASE}/share/texmf-dist/dvips/arphic/config.bkaiu:${PORTSDIR}/print/texlive-arphic \
		${LOCALBASE}/share/texmf-dist/fonts/misc/cns/4040w0.bin:${PORTSDIR}/print/texlive-cns \
		${LOCALBASE}/share/texmf-dist/tex/latex/ctex/ctex.sty:${PORTSDIR}/print/texlive-ctex \
		${LOCALBASE}/share/texmf-dist/fonts/opentype/public/fandol/FandolFang-Regular.otf:${PORTSDIR}/print/texlive-fandol \
		${LOCALBASE}/share/texmf-dist/tex/latex/xpinyin/xpinyin.sty:${PORTSDIR}/print/texlive-xpinyin \
		${LOCALBASE}/share/texmf-dist/fonts/tfm/zhmetrics/cyberb/cyberb00.tfm:${PORTSDIR}/print/texlive-zhmetrics \
		${LOCALBASE}/share/texmf-dist/tex/latex/zhnumber/zhnumber.sty:${PORTSDIR}/print/texlive-zhnumber \
		${LOCALBASE}/share/texmf-dist/tex/xetex/zhspacing/generic/zhspacing.sty:${PORTSDIR}/print/texlive-zhspacing

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
