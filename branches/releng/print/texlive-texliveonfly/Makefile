# $FreeBSD$

PORTNAME=	texliveonfly
PORTVERSION=	20120515
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	On-the-fly download of missing TeX live packages.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
