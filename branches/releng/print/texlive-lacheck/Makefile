# New ports collection makefile for:	texlive-lacheck
# Date created:		13/03/2010 04:24:12
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	lacheck
PORTVERSION=	20110209
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	LaTeX checker.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
