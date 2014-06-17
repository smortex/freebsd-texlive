# $FreeBSD$

PORTNAME=	kotex-utils
PORTVERSION=	20140418
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Utility scripts and support files for typesetting Korean.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/kotex-utf/contrib/dhucs-cmap.sty:${PORTSDIR}/print/texlive-kotex-utf \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
