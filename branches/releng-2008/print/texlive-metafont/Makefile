# New ports collection makefile for:	texlive-metafont
# Date created:		26/01/2009 16:02:44
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	metafont
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The metafont package

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.metafont.cnf:${PORTSDIR}/print/texlive-bin-metafont

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
