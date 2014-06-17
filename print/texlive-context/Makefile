# $FreeBSD$

PORTNAME=	context
PORTVERSION=	20140523
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The ConTeXt macro package.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/afm/metapost/freeeuro.afm:${PORTSDIR}/print/texlive-metapost \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/dummy-space/dummy-space.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/fonts/misc/xetex/fontmapping/base/qx-unicode.map:${PORTSDIR}/print/texlive-xetex \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/lm/lmb10.afm:${PORTSDIR}/print/texlive-lm \
		${LOCALBASE}/share/texmf-dist/fonts/opentype/public/lm-math/latinmodern-math.otf:${PORTSDIR}/print/texlive-lm-math \
		${LOCALBASE}/share/texmf-dist/tex/latex/stmaryrd/stmaryrd.sty:${PORTSDIR}/print/texlive-stmaryrd \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/tex/generic/context/mptopdf/mptopdf.tex:${PORTSDIR}/print/texlive-mptopdf \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
