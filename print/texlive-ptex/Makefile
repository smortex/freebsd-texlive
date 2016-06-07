# $FreeBSD$

PORTNAME=	ptex
PORTVERSION=	20160518
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A TeX system for publishing in Japanese

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/adobemapping/README:${PORTSDIR}/print/texlive-adobemapping \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/public/ipaex/ipaexg.ttf:${PORTSDIR}/print/texlive-ipaex \
		${LOCALBASE}/share/texmf-dist/tex/platex/japanese/japanese.ldf:${PORTSDIR}/print/texlive-japanese \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/japanese-otf/otf-cktx.map:${PORTSDIR}/print/texlive-japanese-otf \
		${LOCALBASE}/share/texmf-dist/pbibtex/bib/jxampl.bib:${PORTSDIR}/print/texlive-pbibtex-base \
		${LOCALBASE}/share/texmf-dist/tex/ptex/ptex-base/ascii-jplain.tex:${PORTSDIR}/print/texlive-ptex-base \
		${LOCALBASE}/share/texmf-dist/fonts/source/ptex-fonts/ascgrp/ascgrp.mf:${PORTSDIR}/print/texlive-ptex-fonts

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
