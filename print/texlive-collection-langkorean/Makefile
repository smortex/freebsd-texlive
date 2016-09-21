# $FreeBSD$

PORTNAME=	collection-langkorean
PORTVERSION=	20160920
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Korean

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-dvipdfmx \
		${LOCALBASE}/share/texmf-dist/dvips/base/color.pro:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/etex/xbmc10.mf:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf-dist/tex/latex/graphics-def/dvipdfmx.def:${PORTSDIR}/print/texlive-graphics-def \
		${LOCALBASE}/share/texmf-dist/dvips/gsftopk/render.ps:${PORTSDIR}/print/texlive-gsftopk \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/oberdiek/ifluatex.sty:${PORTSDIR}/print/texlive-ifluatex \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-lib/3test.mf:${PORTSDIR}/print/texlive-knuth-lib \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-local/black.mf:${PORTSDIR}/print/texlive-knuth-local \
		${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/scripts/lua-alt-getopt/alt_getopt.lua:${PORTSDIR}/print/texlive-lua-alt-getopt \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/mf.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/mft/base/README:${PORTSDIR}/print/texlive-mfware \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/dummy-space/dummy-space.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-tetex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf-dist/tex/generic/tex-ini-files/dvilualatex.ini:${PORTSDIR}/print/texlive-tex-ini-files \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/texconfig.sh:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf-dist/tex/generic/unicode-data/CaseFolding.txt:${PORTSDIR}/print/texlive-unicode-data \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/updmap/kanjix.map:${PORTSDIR}/print/texlive-updmap-map \
		${LOCALBASE}/share/texmf-dist/dvips/xdvi/config.xdvi:${PORTSDIR}/print/texlive-xdvi \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/adobemapping/README:${PORTSDIR}/print/texlive-adobemapping \
		${LOCALBASE}/share/texmf-dist/fonts/enc/dvips/c90/c90.enc:${PORTSDIR}/print/texlive-c90 \
		${LOCALBASE}/share/texmf-dist/scripts/cjk-gs-integrate/cjk-gs-integrate.pl:${PORTSDIR}/print/texlive-cjk-gs-integrate \
		${LOCALBASE}/share/texmf-dist/tex/latex/cjk/contrib/wadalab/c42goth.fd:${PORTSDIR}/print/texlive-cjk \
		${LOCALBASE}/share/texmf-dist/tex/latex/cjkpunct/CJKpunct.spa:${PORTSDIR}/print/texlive-cjkpunct \
		${LOCALBASE}/share/texmf-dist/hbf2gf/README:${PORTSDIR}/print/texlive-cjkutils \
		${LOCALBASE}/share/texmf-dist/fonts/sfd/dnp/DNP.sfd:${PORTSDIR}/print/texlive-dnp \
		${LOCALBASE}/share/texmf-dist/dvips/garuda-c90/config.garuda-c90:${PORTSDIR}/print/texlive-garuda-c90 \
		${LOCALBASE}/share/texmf-dist/dvips/norasi-c90/config.norasi-c90:${PORTSDIR}/print/texlive-norasi-c90 \
		${LOCALBASE}/share/texmf-dist/tex/latex/xcjk2uni/cmap/c0001.cmap:${PORTSDIR}/print/texlive-xcjk2uni \
		${LOCALBASE}/share/texmf-dist/tex/latex/zxjafont/zxjafont.sty:${PORTSDIR}/print/texlive-zxjafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/cjk-ko/cjkutf8-josa.sty:${PORTSDIR}/print/texlive-cjk-ko \
		${LOCALBASE}/share/texmf-dist/tex/latex/kotex-oblivoir/memhangul-ucs/10_5.sty:${PORTSDIR}/print/texlive-kotex-oblivoir \
		${LOCALBASE}/share/texmf-dist/tex/plain/kotex-plain/hangulcweb.tex:${PORTSDIR}/print/texlive-kotex-plain \
		${LOCALBASE}/share/texmf-dist/tex/latex/kotex-utf/contrib/dhucs-cmap.sty:${PORTSDIR}/print/texlive-kotex-utf \
		${LOCALBASE}/share/texmf-dist/makeindex/kotex-utils/kotex.ist:${PORTSDIR}/print/texlive-kotex-utils \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/nanumtype1/nanumgtb00.afm:${PORTSDIR}/print/texlive-nanumtype1 \
		${LOCALBASE}/share/texmf-dist/dvips/uhc/config.uhc:${PORTSDIR}/print/texlive-uhc \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/public/unfonts-core/UnBatang.ttf:${PORTSDIR}/print/texlive-unfonts-core \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/public/unfonts-extra/UnBom.ttf:${PORTSDIR}/print/texlive-unfonts-extra

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
